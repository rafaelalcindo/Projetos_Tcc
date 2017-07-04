package playDll;

import com.sun.jna.Native;
import libs.DisplayHello;

public class DllFunction {
	public static void main(String[] args){
		
		DisplayHello display = (DisplayHello)Native.loadLibrary("TestLib", DisplayHello.class);
		display.DisplayHelloFromDLL();	
	}
}
