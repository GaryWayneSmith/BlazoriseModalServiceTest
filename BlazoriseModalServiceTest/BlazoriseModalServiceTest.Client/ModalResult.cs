namespace BlazoriseModalServiceTest.Client
{
    public class ModalResult<TResult>
    {
        public ModalResultType ResultType { get; private set; } = ModalResultType.NoSet;
        public TResult Data { get; set; } = default;

        public static ModalResult<TResult> OK() => new ModalResult<TResult>() { ResultType = ModalResultType.OK };
        public static ModalResult<TResult> Exit() => new ModalResult<TResult>() { ResultType = ModalResultType.Exit };
        public static ModalResult<TResult> Cancel() => new ModalResult<TResult>() { ResultType = ModalResultType.Cancel };
        public static ModalResult<TResult> OK(TResult data) => new ModalResult<TResult>() { Data = data, ResultType = ModalResultType.OK };
        public static ModalResult<TResult> Exit(TResult data) => new ModalResult<TResult>() { Data = data, ResultType = ModalResultType.Exit };
        public static ModalResult<TResult> Cancel(TResult data) => new ModalResult<TResult>() { Data = data, ResultType = ModalResultType.Cancel };

        public enum ModalResultType { NoSet, OK, Cancel, Exit }
    }
}
