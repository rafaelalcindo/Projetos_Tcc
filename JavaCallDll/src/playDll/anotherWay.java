package playDll;

public class anotherWay {
	public static void main(String[] args){
		try{
			System.load("C:/Projetos/TestLib/Debug/TestLib.dll");
		}catch(UnsatisfiedLinkError e){
			System.err.println("Native code library failed to load.\n" + e);
		}
	}
}
