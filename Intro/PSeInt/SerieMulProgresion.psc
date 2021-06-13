lgoritmo SerieMultProgresion
	Definir s1, s2, c,n, i,aux Como Entero;
	Definir sw Como Logico; 
	
	s1<-1;
	s2<-3;
	c<-1;
	i<-1;
	aux<-2;
	sw<-Verdadero;
	Leer n;

	Mientras i<= n Hacer
		Si sw = Verdadero
			Mostrar s1;
			s1<-aux*c;
			aux<-s1;
			c<-c+1;
			sw<-Falso;
		SiNo
			Mostrar s2;
			s2<-s2+3;
			sw<-Verdadero;
		FinSi
		
		i<-i+1;
	FinMientras
	
	
FinAlgoritmo
