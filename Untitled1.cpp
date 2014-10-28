#include <stdio.h>
int main()
{
    int x = 4, y = 3;
    printf("%d %d %d\n", x<y, -(x<y), y^((x^y)&-(x<y)));
    getchar();getchar();
 //   system("pause");
    return 0;
}
