using System;
using System.Collections.Generic;
using System.Diagnostics;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Smart.iOS
{
    public class ViewControllerAnimationFixedReturnSmooth : UIViewController
    {
        CAShapeLayer _verticleLine;
        UISlider _slider;
        CAKeyFrameAnimation _morph;
        float _lineMargin;

        // widok został załadowany
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _verticleLine = CreateLine();
            _morph = CAKeyFrameAnimation.FromKeyPath("path");

            _slider = new UISlider(new CGRect(0, View.Frame.Height - 120, View.Frame.Width, 44));
            _slider.BackgroundColor = UIColor.White;
            _slider.MinValue = 0;
            _slider.MaxValue = 300;

            NavigationController.NavigationBar.TintColor = UIColor.Red;
            NavigationController.NavigationBar.BarTintColor = UIColor.Red;
            View.BackgroundColor = UIColor.White;

            View.Layer.AddSublayer(_verticleLine);
            View.AddSubview(_slider);

            _slider.ValueChanged += delegate {
                _lineMargin = _slider.Value;
            };

            // Drag(Pan) gesture
            View.AddGestureRecognizer(new UIPanGestureRecognizer(pan =>
            {
                var tranaslation = pan.TranslationInView(this.View);
                var p = pan.LocationInView(this.View);
                var v = pan.VelocityInView(this.View);
                Debug.WriteLine("Pan. transration:{0}, velocity:{1}", tranaslation, v);
            
                _verticleLine.Path = GetLinePathWithAmount((float)p.Y, _lineMargin);

                Debug.WriteLine("State :{0}", pan.State);
                if (pan.State == UIGestureRecognizerState.Ended)
                {
                    AnimateLineReturnFrom((float)p.Y, _lineMargin);
                }

            }));

            void AnimateLineReturnFrom(float positionY, float maring)
            {
                // TODO: animacja :)                   
                _morph.TimingFunction = CAMediaTimingFunction.FromName(CAMediaTimingFunction.EaseIn);
                List<CGPath> list = new List<CGPath>();
                list.Add(GetLinePathWithAmount(positionY, maring));
                list.Add(GetLinePathWithAmount(positionY * 0.9f, maring));
                list.Add(GetLinePathWithAmount(positionY * 0.6f, maring));
                list.Add(GetLinePathWithAmount(positionY * 0.4f, maring));
                list.Add(GetLinePathWithAmount(positionY * 0.25f, maring));
                list.Add(GetLinePathWithAmount(0, maring));

                NSObject[] values = new NSObject[]
                {
                    NSObject.FromObject(list[0]),
                    NSObject.FromObject(list[1]),
                    NSObject.FromObject(list[2]),
                    NSObject.FromObject(list[3]),
                    NSObject.FromObject(list[4]),
                    NSObject.FromObject(list[5]),
                };
                _morph.Values = values;
                _morph.Duration = 0.6;
                _morph.RemovedOnCompletion = false;
                _morph.FillMode = CAFillMode.Forwards;

                _verticleLine.AddAnimation(_morph, "return");
            }

            _morph.AnimationStopped += delegate {
                _verticleLine.Path = GetLinePathWithAmount(0, _lineMargin);
                _verticleLine.RemoveAllAnimations();
            };

            CAShapeLayer CreateLine()
            {
                _verticleLine = new CAShapeLayer();
                _verticleLine.StrokeColor = UIColor.Red.CGColor;
                _verticleLine.LineWidth = 3;
                _verticleLine.Path = GetLinePathWithAmount(0, 0);
                _verticleLine.FillColor = UIColor.Red.CGColor;

                return _verticleLine;
            }

			CGPath GetLinePathWithAmount(float amount, float margin, float offset = 20)
            {
                UIBezierPath verticleLine = new UIBezierPath();
                CGPoint topPoint = new CGPoint(0 - margin, 0);
				CGPoint midControlPoint = new CGPoint(View.Bounds.Width / 2, amount + offset);
                CGPoint bottomPoint = new CGPoint(View.Bounds.Width + margin, 0);

                verticleLine.MoveTo(topPoint);
                verticleLine.AddQuadCurveToPoint(bottomPoint, midControlPoint);

                return verticleLine.CGPath;
            }
        }

        // widok zmienił rozmiar ramki
        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
        }
    }
}
