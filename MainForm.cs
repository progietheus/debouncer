public class MainForm
{	
	private Debouncer debouncer;
	
	private void MainForm() {
		debouncer = new Debouncer();
		debouncer.Idled += debouncer_Idled;
	}
	
	private void ipTextBox_TextChanged(object sender, TextChangedEventArgs e)
	{
		debouncer.TextChanged();
	}
	
	private void debouncer_Idled(object sender, EventArgs e)
	{
		//Code you would like to execute after debounce
	}
	
}