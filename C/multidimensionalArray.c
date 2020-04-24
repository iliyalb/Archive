#include <stdio.h>

int main(int argc, char *argv[])
{
    int dimensions[2][3][4] = 
    {
        {
            {10,20,30,40},
            {55,65,75,85},
            {90,93,96,99}
        },
        {
            {10,20,30,40},
            {55,65,75,85},
            {90,93,96,99}
        }
    };

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            for (int k = 0; k < 4; k++)
            {
                printf("%d\t",dimensions[i][j][k]);
            }
            
        }
        
    }
    
    return 0;
}