#include <stdio.h>

int main(void){

  printf("問1\n");
  double a = 111.11;
  int b = 1;
  int c;
  c = a + b;
  printf("%2.1f%2.1d%2.1d",a,b,c);

  printf("問2\n");
  int x=0;
  int y=1;
  {
    int x = 5;
    y = 2;
  }
  {
    int y = x;
    printf("%d %d\n", x,y);
  }
  printf("%d %d\n", x,y);
  return(0);
}
