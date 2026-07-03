Algoritmo Lecc17_Act3_Inc1
	Definir fila,columna,num,suma Como Entero
	Definir tabla Como Entero
	Dimensionar tabla[4,3]
	
	Para fila = 1 Hasta 4 Hacer
		suma = 0
		Para columna = 1 Hasta 3 Hacer
			Escribir "Ingrese un numero: "
			Leer num
			tabla[fila,columna]=num
			suma = suma + num
		FinPara
		Escribir "La suma de la fila ",fila," Es: ",suma
	FinPara
FinAlgoritmo
