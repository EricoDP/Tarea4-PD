package Main;

public class AntComplejo extends Complejo{

	@Override
	void Comenzar() {
		System.out.println("Revision compleja - Revision compleja comenzada");
	}

	@Override
	void Memoria() {
		try {
			System.out.println("Revizando Memoria Ram...");
			Thread.sleep(1000);
		}catch(InterruptedException e) {
			e.printStackTrace();
		}
	}

	@Override
	void KeyLoggers() {
		try {
			System.out.println("Revizando KeyLoggers...");
			Thread.sleep(1000);
		}catch(InterruptedException e) {
			e.printStackTrace();
		}
	}

	@Override
	void RootKis() {
		try {
			System.out.println("Revizando RootKis...");
			Thread.sleep(1000);
		}catch(InterruptedException e) {
			e.printStackTrace();
		}
	}

	@Override
	void Descomprimir() {
		try {
			System.out.println("Revizando archivos .zip ...");
			Thread.sleep(1000);
		}catch(InterruptedException e) {
			e.printStackTrace();
		}		
	}

	@Override
	void Finalizar() {
		System.out.println("Revision sencilla - Revision sencilla finalizada");				
	}

}
