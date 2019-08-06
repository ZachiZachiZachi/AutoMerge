using System;
using System.ComponentModel;
using System.Threading;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using EnvDTE;
using Thread = System.Threading.Thread;

namespace AutoMerge
{
	/// <summary>
	/// Interaction logic for BranchesView.xaml
	/// </summary>
	public partial class BranchesView : UserControl
	{
	    private BackgroundWorker _worker = null;

	    public BranchesView()
		{
			InitializeComponent();
		}
        
		private void Btn_yes_OnClick(object sender, RoutedEventArgs e)
		{
		    _worker = new BackgroundWorker();
		    _worker.WorkerSupportsCancellation = true;
		    _worker.DoWork += new DoWorkEventHandler((state, arg) =>
		    {
		        do
		        {
		            if (_worker.CancellationPending)
		                break;

		            MessageBox.Show("Hello World");
		        } while (true);
		    });
            _worker.RunWorkerAsync();
		}

		private void Btn_no_OnClick(object sender, RoutedEventArgs e)
		{
            _worker.CancelAsync();
		}
	}
}
