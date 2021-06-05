Algoritmo DobleSerie123YMas3
	Definir s1, s2, n Como Entero;
	Definir sw Como Logico; 
	sw<- Verdadero;
	s1<-0; s2<- -3;
	Leer n;
	Mientras (n>0) Hacer
		Si (sw == Verdadero) Entonces
			s1<-s1+1;
			Mostrar s1;
			sw<-Falso;
		SiNo
			s2<-s2+3;
			Mostrar s2;
			sw<-Verdadero;
		FinSi
		n<-n-1;
	FinMientras
FinAlgoritmo
