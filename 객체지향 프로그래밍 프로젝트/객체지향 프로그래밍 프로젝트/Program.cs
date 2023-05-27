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
            string mtxName = "Metashower";
            Mutex mtx = new Mutex(true, mtxName);

            // 1초 동안 뮤텍스를 획득하려 대기  
            TimeSpan tsWait = new TimeSpan(0, 0, 1);
            bool success = mtx.WaitOne(tsWait);

            // 실패하면 프로그램 종료  
            if (!success)
            {
                MessageBox.Show("이미실행중입니다.");
                return;

            }

            // 성공하면 폼 실행  
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}