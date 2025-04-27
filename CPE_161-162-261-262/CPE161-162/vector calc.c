#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <conio.h>
#define PI 3.1415926535897932384626433

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int GetVectorNumbers(void);
void VectorResultant(int VectorNumbers);

int main()
{
	int VectorNumbers = GetVectorNumbers();
	VectorResultant(VectorNumbers);
	return 0;
}

int GetVectorNumbers(void)
{
	//get number of vectors
	int VectorNumbers;
	printf("Enter number of vectors: ");
	scanf("%d", &VectorNumbers);
	printf("\n");
	
	return VectorNumbers;
}

void VectorResultant(int VectorNumbers)
{
	//vector variables
	double vector_mag[VectorNumbers];
	double vector_ang[VectorNumbers];
	
	//input number of vectors
	for (int i = 0, n = VectorNumbers; i < n; i++)
	{
		printf("Enter magnitude of vector %d: ", i + 1);
		scanf("%lf", &vector_mag[i]);
		
		printf("Enter angle of vector %d: ", i + 1);
		scanf("%lf", &vector_ang[i]);
		printf("\n");
		
		vector_ang[i] = vector_ang[i] * PI / 180.0;
	}
	
	//calculate resultant vector
	double resultant_x = 0.0;
	double resultant_y = 0.0;
	
	for (int i = 0, n = VectorNumbers; i < n; i++)
	{
		resultant_x += vector_mag[i] * cos(vector_ang[i]);
		resultant_y += vector_mag[i] * sin(vector_ang[i]);
	}
	
	//calculate magnitude of the resultant vector
	double result_mag = sqrt(resultant_x * resultant_x + resultant_y * resultant_y);
	double result_ang = atan2(resultant_y, resultant_x)* 180.0 / PI;
	
	printf("\nUnit Vectors: %.2lfi + %.2lfj\n", resultant_x, resultant_y);
	printf("Resultant Vector: %.2lf\n", result_mag);
	printf("Direction: %.2lf degrees\n", result_ang);
	getch();
}

