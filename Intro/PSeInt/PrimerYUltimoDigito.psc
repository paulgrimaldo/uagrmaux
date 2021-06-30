Algoritmo PrimerYUltimoDigito
	Definir n,nu, ud, pd Como Entero;
	
	Leer n;
	
	pd<-n mod 10;
	n<- trunc(n/10);
	nu<-pd;
	Mientras n > 0 Hacer
		ud<- n mod 10;
		n<- trunc(n/10);
	FinMientras
	nu<-nu+ud*10;
	
	Escribir "Primer digito: ", pd;
	Escribir "Ultimo digito: ", ud;
	Escribir "Nuevo numero: ", nu;
	
FinAlgoritmo
