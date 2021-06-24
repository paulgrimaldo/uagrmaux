Algoritmo eliminarPrimerYUltimoDigito
	Definir n, d, nu, i Como Entero;
	nu<-0;
	i<-0;
	Leer n;
	
	//Recorto el primer (o ultimo) digito de entrada
	n<-trunc(n/10);
	
	Mientras n>10 Hacer
		d<-n mod 10;
		n<-trunc(n/10);
		
		nu<-nu+d*10^i; 
		
		i<-i+1;
	FinMientras
	
	Escribir "Nuevo numero: ",nu;
FinAlgoritmo
