using MittaUI.Runtime.Constant;
using MittaUI.Runtime.Parts;
using NaughtyAttributes;
using UnityEngine;
using LitMotion;
using LitMotion.Extensions;

namespace MittaUI.Runtime
{
    [AddComponentMenu(AddComponentMenuConst.ButtonBath + nameof(SimpleButton))]
    public sealed class SimpleButton : BaseButtonWithLongTapGesture
    {
        [Header("===ボタンのアニメーションのパラメータ===")] [Header("アニメーションをさせるかどうか    ")] [SerializeField]
        private bool _doAnimation = true;

        [SerializeField] [Header("ボタンをアニメーションさせるTransform")] [ShowIf(nameof(_doAnimation))]
        private Transform _buttonAnimationTransform;

        [SerializeField] [Header("押下後のスケール")] [ShowIf(nameof(_doAnimation))]
        private float _buttonAnimationPressScale = 0.9f;

        [SerializeField] [Header("完全に押下するまでの時間")] [ShowIf(nameof(_doAnimation))]
        private float _buttonAnimationPressDuration = 0.25f;

        [SerializeField] [Header("押下時のイージング")] [ShowIf(nameof(_doAnimation))]
        private Ease _buttonAnimationPressEase = Ease.OutSine;

        [SerializeField] [Header("元の大きさに戻るまでの時間")] [ShowIf(nameof(_doAnimation))]
        private float _buttonAnimationPullDuration = 0.25f;

        [SerializeField] [Header("デフォルトのスケール")] [ShowIf(nameof(_doAnimation))]
        private float _buttonAnimationDefaultScale = 1f;

        //TODO  大きさを元に戻す処理を実装する
        //[SerializeField] [Header("元の大きさの戻る時のイージング")] [ShowIf(nameof(_doAnimation))]
        //private Ease _buttonAnimationPullEase = Ease.OutSine;

#if UNITY_EDITOR
        protected override void Reset()
        {
            base.Reset();
            _buttonAnimationTransform ??= GetComponent<Transform>();
        }
#endif

        protected override void OnPressed(bool isPressed)
        {
            if (!_doAnimation) return;

            var go = _buttonAnimationTransform.gameObject;
            var motionHandle = new CompositeMotionHandle();
            motionHandle.Complete();

            if (isPressed)
            {

                LMotion.Create(Vector3.one, Vector3.one * _buttonAnimationPressScale, _buttonAnimationPressDuration)
                    .WithLoops(2, LoopType.Yoyo)
                    .WithEase(_buttonAnimationPressEase)
                    .BindToLocalScale(transform)
                    .AddTo(gameObject);
            }
        }
    }
}