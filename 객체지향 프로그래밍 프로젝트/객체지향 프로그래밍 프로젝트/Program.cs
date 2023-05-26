namespace 객체지향_프로그래밍_프로젝트
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isFirstInstance;
            using (Mutex mutex = new Mutex(true, "UniqueAppMutex", out isFirstInstance))
            {
                if (isFirstInstance)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainPage());
                }
                else
                {
                    // 이미 실행 중인 경우 처리할 작업
                    // 예: 이미 열려 있는 폼으로 포커스를 이동시키기
                }
            }
        }
    }
}