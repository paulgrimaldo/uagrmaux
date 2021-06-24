Algoritmo mayorPosicionesImpares
	Definir n, d, m, i Como Entero;
	Leer n;
	
	//Valor inicial m (mayor) en el primer digito
	m<-n mod 10;
	i<-1;
	Mientras n>0 Hacer
		d<- n mod 10;
		n<-trunc(n/10);
		
		//Si estoy en un indice impar
		Si (i mod 2) = 1 Entonces
			//Verificando si el digito es mayor al mayor anterior
			Si (d >= m) Entonces
				m<- d;
			FinSi
		FinSi
		
		i<-i+1;
		
	FinMientras
	
	Escribir "Mayor: ", m;
	
FinAlgoritmo
