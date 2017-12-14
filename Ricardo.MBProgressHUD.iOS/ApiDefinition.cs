using System;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Ricardo.RMBProgressHUD.iOS
{
    // typedef void (^MBProgressHUDCompletionBlock)();
    delegate void MBProgressHUDCompletionBlock();

    // @interface MBProgressHUD : UIView
    [BaseType(typeof(UIView))]
    interface MBProgressHUD
    {
        // +(instancetype _Nonnull)showHUDAddedTo:(UIView * _Nonnull)view animated:(BOOL)animated;
        [Static]
        [Export("showHUDAddedTo:animated:")]
        MBProgressHUD ShowHUD(UIView view, bool animated);

        // +(BOOL)hideHUDForView:(UIView * _Nonnull)view animated:(BOOL)animated;
        [Static]
        [Export("hideHUDForView:animated:")]
        bool HideHUD(UIView view, bool animated);

        // +(MBProgressHUD * _Nullable)HUDForView:(UIView * _Nonnull)view;
        [Static]
        [Export("HUDForView:")]
        [return: NullAllowed]
        MBProgressHUD HUDForView(UIView view);

        // -(instancetype _Nonnull)initWithView:(UIView * _Nonnull)view;
        [Export("initWithView:")]
        IntPtr Constructor(UIView view);

        // -(void)showAnimated:(BOOL)animated;
        [Export("showAnimated:")]
        void Show(bool animated);

        // -(void)hideAnimated:(BOOL)animated;
        [Export("hideAnimated:")]
        void Hide(bool animated);

        // -(void)hideAnimated:(BOOL)animated afterDelay:(NSTimeInterval)delay;
        [Export("hideAnimated:afterDelay:")]
        void Hide(bool animated, double delay);

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MBProgressHUDDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MBProgressHUDDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (copy) MBProgressHUDCompletionBlock _Nullable completionBlock;
        [NullAllowed, Export("completionBlock", ArgumentSemantic.Copy)]
        MBProgressHUDCompletionBlock CompletionBlock { get; set; }

        // @property (assign, nonatomic) NSTimeInterval graceTime;
        [Export("graceTime")]
        double GraceTime { get; set; }

        // @property (assign, nonatomic) NSTimeInterval minShowTime;
        [Export("minShowTime")]
        double MinShowTime { get; set; }

        // @property (assign, nonatomic) BOOL removeFromSuperViewOnHide;
        [Export("removeFromSuperViewOnHide")]
        bool RemoveFromSuperViewOnHide { get; set; }

        // @property (assign, nonatomic) MBProgressHUDMode mode;
        [Export("mode", ArgumentSemantic.Assign)]
        MBProgressHUDMode Mode { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable contentColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("contentColor", ArgumentSemantic.Strong)]
        UIColor ContentColor { get; set; }

        // @property (assign, nonatomic) MBProgressHUDAnimation animationType __attribute__((annotate("ui_appearance_selector")));
        [Export("animationType", ArgumentSemantic.Assign)]
        MBProgressHUDAnimation AnimationType { get; set; }

        // @property (assign, nonatomic) CGPoint offset __attribute__((annotate("ui_appearance_selector")));
        [Export("offset", ArgumentSemantic.Assign)]
        CGPoint Offset { get; set; }

        // @property (assign, nonatomic) CGFloat margin __attribute__((annotate("ui_appearance_selector")));
        [Export("margin")]
        nfloat Margin { get; set; }

        // @property (assign, nonatomic) CGSize minSize __attribute__((annotate("ui_appearance_selector")));
        [Export("minSize", ArgumentSemantic.Assign)]
        CGSize MinSize { get; set; }

        // @property (getter = isSquare, assign, nonatomic) BOOL square __attribute__((annotate("ui_appearance_selector")));
        [Export("square")]
        bool Square { [Bind("isSquare")] get; set; }

        // @property (getter = areDefaultMotionEffectsEnabled, assign, nonatomic) BOOL defaultMotionEffectsEnabled __attribute__((annotate("ui_appearance_selector")));
        [Export("defaultMotionEffectsEnabled")]
        bool DefaultMotionEffectsEnabled { [Bind("areDefaultMotionEffectsEnabled")] get; set; }

        // @property (assign, nonatomic) float progress;
        [Export("progress")]
        float Progress { get; set; }

        // @property (nonatomic, strong) NSProgress * _Nullable progressObject;
        [NullAllowed, Export("progressObject", ArgumentSemantic.Strong)]
        NSProgress ProgressObject { get; set; }

        // @property (readonly, nonatomic, strong) MBBackgroundView * _Nonnull bezelView;
        [Export("bezelView", ArgumentSemantic.Strong)]
        MBBackgroundView BezelView { get; }

        // @property (readonly, nonatomic, strong) MBBackgroundView * _Nonnull backgroundView;
        [Export("backgroundView", ArgumentSemantic.Strong)]
        MBBackgroundView BackgroundView { get; }

        // @property (nonatomic, strong) UIView * _Nullable customView;
        [NullAllowed, Export("customView", ArgumentSemantic.Strong)]
        UIView CustomView { get; set; }

        // @property (readonly, nonatomic, strong) UILabel * _Nonnull label;
        [Export("label", ArgumentSemantic.Strong)]
        UILabel Label { get; }

        // @property (readonly, nonatomic, strong) UILabel * _Nonnull detailsLabel;
        [Export("detailsLabel", ArgumentSemantic.Strong)]
        UILabel DetailsLabel { get; }

        // @property (readonly, nonatomic, strong) UIButton * _Nonnull button;
        [Export("button", ArgumentSemantic.Strong)]
        UIButton Button { get; }
    }

    // @protocol MBProgressHUDDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MBProgressHUDDelegate
    {
        // @optional -(void)hudWasHidden:(MBProgressHUD * _Nonnull)hud;
        [Export("hudWasHidden:")]
        void HudWasHidden(MBProgressHUD hud);
    }

    // @interface MBRoundProgressView : UIView
    [BaseType(typeof(UIView))]
    interface MBRoundProgressView
    {
        // @property (assign, nonatomic) float progress;
        [Export("progress")]
        float Progress { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull progressTintColor;
        [Export("progressTintColor", ArgumentSemantic.Strong)]
        UIColor ProgressTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull backgroundTintColor;
        [Export("backgroundTintColor", ArgumentSemantic.Strong)]
        UIColor BackgroundTintColor { get; set; }

        // @property (getter = isAnnular, assign, nonatomic) BOOL annular;
        [Export("annular")]
        bool Annular { [Bind("isAnnular")] get; set; }
    }

    // @interface MBBarProgressView : UIView
    [BaseType(typeof(UIView))]
    interface MBBarProgressView
    {
        // @property (assign, nonatomic) float progress;
        [Export("progress")]
        float Progress { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull lineColor;
        [Export("lineColor", ArgumentSemantic.Strong)]
        UIColor LineColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull progressRemainingColor;
        [Export("progressRemainingColor", ArgumentSemantic.Strong)]
        UIColor ProgressRemainingColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull progressColor;
        [Export("progressColor", ArgumentSemantic.Strong)]
        UIColor ProgressColor { get; set; }
    }

    // @interface MBBackgroundView : UIView
    [BaseType(typeof(UIView))]
    interface MBBackgroundView
    {
        // @property (nonatomic) MBProgressHUDBackgroundStyle style;
        [Export("style", ArgumentSemantic.Assign)]
        MBProgressHUDBackgroundStyle Style { get; set; }

        // @property (nonatomic) UIBlurEffectStyle blurEffectStyle;
        [Export("blurEffectStyle", ArgumentSemantic.Assign)]
        UIBlurEffectStyle BlurEffectStyle { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull color;
        [Export("color", ArgumentSemantic.Strong)]
        UIColor Color { get; set; }
    }
}
