# Debouncer
A simple typing debouncer implementation for C# applications

---

### Installation
Add debouncer.cs class to your project

### How to use


```cs
public class MainForm
{	
	private Debouncer debouncer;
	
    //1. Define your event handling!
	private void MainForm() {
		debouncer = new Debouncer();
		debouncer.Idled += debouncer_Idled;
	}
	
    //2. When you start typing, you reset the debounce timer!
	private void ipTextBox_TextChanged(object sender, TextChangedEventArgs e)
	{
		debouncer.TextChanged();
	}
	
    //3. Execution of code
	private void debouncer_Idled(object sender, EventArgs e)
	{
		//Code you would like to execute after debounce!
	}
	
}
```
### Credits

http://thargy.com/2014/03/debouncing-asynchronous-operations/
