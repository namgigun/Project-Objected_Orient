namespace 객체지향_프로그래밍_프로젝트
{
    internal static class Program
    {
        private const string MutexName = "MyUniqueMutexName";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            using (Mutex mutex = new Mutex(true, MutexName, out bool createdNew))
            {
                if (createdNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Login());
                }
                else
                {
                    // 이미 실행 중인 경우 처리할 로직
                    // 예를 들어 기존 인스턴스로 포커스를 이동시킬 수 있습니다.
                }
            }
        }
    }
}