namespace iosMauiInterop
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            //var returned = ;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            CounterBtn.Text = MauiProgram.Invoker.ReturnStringWithInput("Hello");

            //count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
