Algoritmo NumerosParesEImpares
	Definir numPares, numImpares, n, d, ip, ii Como Entero;
	
	Leer n;
	ip<-0;
	ii<-0;
	
	Mientras n>0 Hacer
		d<-n mod 10;
		n<-trunc(n/10);
		
		Si (d mod 2) = 0 Entonces
			numPares<-numPares + d*10^ip;
			ip<-ip+1;
		SiNo
			numImpares<-numImpares+d*10^ii;
			ii<-ii+1;
		FinSi
	FinMientras
	Escribir "Numeros con pares: ", numPares
	Escribir "Numeros con impares: ", numImpares
FinAlgoritmo
