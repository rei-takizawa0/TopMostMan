using TopMostMan.Models.Interface;
using TopMostMan.Models.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TopMostMan.Models.Entitys;
using System.Collections.ObjectModel;

namespace TopMostMan.Presenter
{
    internal class MainFormPresenter
    {
        private IMainForm _view;
        public MainFormPresenter(IMainForm view)
        {
            _view = view;
            HandleEvents();
        }

        private void HandleEvents()
        {
            _view.LoadButtonClick += OnLoadButtonClick;
            _view.ReleaseButtonClick += OnReleaseButtonClick;
            _view.TopMostButtonClick += OnTopMostButtonClick;
        }

        private void OnLoadButtonClick(object sender, EventArgs e)
        {
            try
            {
                ReadOnlyCollection<BootingApplication> applications = BootingApplication.Load();
                _view.Applications = applications;
            }
            catch (Exception ex)
            {
                Messages.ShowErrorMessage(ex);
            }
        }
        private void OnReleaseButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (!_view.ApplicationExists)
                {
                    throw new Exception("最前面を解除できません。");
                }
                Release();
            }
            catch (Exception ex)
            {
                Messages.ShowErrorMessage(ex);
            }
        }
        private void Release()
        {
            int processId = _view.CurrentApplication.ProcessId;
            TopMost topMost = new TopMost(processId);
            topMost.Release();
        }

        private void OnTopMostButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (!_view.ApplicationExists)
                {
                    throw new Exception("最前面に設定できません。");
                }
                TopMost();
            }
            catch (Exception ex)
            {
                Messages.ShowErrorMessage(ex);
            }
        }

        private void TopMost()
        {
            int processId = _view.CurrentApplication.ProcessId;
            TopMost topMost = new TopMost(processId);
            topMost.Execute();
        }
    }
}
