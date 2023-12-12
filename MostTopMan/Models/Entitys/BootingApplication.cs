using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
namespace TopMostMan.Models.Entitys
{
    public class BootingApplication
    {

        private readonly string _windowTitle;
        [DisplayName("タイトル名")]
        public string WindowTitle
        {
            get { return _windowTitle; }
        }

        private readonly int _processId;
        [Browsable(false)]
        public int ProcessId
        {
            get { return _processId; }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private BootingApplication(int processId, string windowTitle)
        {
            _processId = processId;
            _windowTitle = windowTitle;
        }

        /// <summary>
        /// ロード処理
        /// </summary>
        /// <returns></returns>
        public static ReadOnlyCollection<BootingApplication> Load()
        {
            return GetApplication();
        }

        /// <summary>
        /// アプリケーション一覧取得
        /// </summary>
        /// <returns></returns>
        private static ReadOnlyCollection<BootingApplication> GetApplication()
        {
            List<BootingApplication> apps = new List<BootingApplication>();
            foreach (Process process in Process.GetProcesses())
            {
                if (IsRunning(process))
                {
                    continue;
                }
                apps.Add(new BootingApplication(process.Id, process.MainWindowTitle));
            }
            return apps.AsReadOnly();
        }

        /// <summary>
        /// 実行中確認
        /// </summary>
        /// <param name="process"></param>
        /// <returns></returns>
        private static bool IsRunning(Process process)
        {
            return process.MainWindowHandle == IntPtr.Zero;
        }
    }
}
