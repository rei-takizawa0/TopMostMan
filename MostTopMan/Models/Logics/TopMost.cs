using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TopMostMan.Models.Logics
{
    public class TopMost
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetWindowPos(IntPtr handle, IntPtr order, int x, int y, int width, int height, uint mode);

        const uint SWP_NOSIZE = 0x0001;
        const uint SWP_NOMOVE = 0x0002;
        const uint TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        private readonly IntPtr _windowHandle;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="processId"></param>
        public TopMost(int processId)
        {
            _windowHandle = GetWindowHandle(processId);
        }

        /// <summary>
        /// Window情報取得
        /// </summary>
        /// <param name="processId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private IntPtr GetWindowHandle(int processId)
        {
            if (!ProcessExists(processId))
            {
                throw new Exception("対象のプロセスが見つかりませんでした。");
            }
            return GetMainWindowHandle(processId);
        }

        /// <summary>
        /// Window情報取得
        /// </summary>
        /// <param name="processId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        static IntPtr GetMainWindowHandle(int processId)
        {
            Process process = Process.GetProcessById(processId);
            if (process.MainWindowHandle == IntPtr.Zero)
            {
                throw new Exception("対象のウィンドウが見つかりませんでした。");
            }
            return process.MainWindowHandle;
        }

        /// <summary>
        /// プロセスの存在確認
        /// </summary>
        /// <param name="processId"></param>
        /// <returns></returns>
        private bool ProcessExists(int processId)
        {
            return processId != 0;
        }

        /// <summary>
        /// 最前面へ
        /// </summary>
        public void Execute()
        {
            SetWindowPos(_windowHandle, new IntPtr(-1), 0, 0, 0, 0, TOPMOST_FLAGS);
        }

        /// <summary>
        /// 解除
        /// </summary>
        public void Release()
        {
            SetWindowPos(_windowHandle, IntPtr.Zero, 0, 0, 0, 0, TOPMOST_FLAGS);
        }
    }
}
