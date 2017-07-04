%{
   #define YYSTYPE void*

   #include <stdio.h>
   #include <stdlib.h>   
   #include "compilador.h"
   
   void  encerraCompilacao()
   {
      printf("\n\n --> Pressione <ENTER> para finalizar ...\n");
      getchar();  
      exit(0);
   }

   #include "lex.yy.c"
   
   void yyerror (char const * msg)
   {
   }

   int yywrap()
   {
     return 1;
   }
   
%}

%token IDENTIFICADOR

%%
inicio
  : callList

callList
  : call
  | callList call

call
  : IDENTIFICADOR '('  ')' ';'  { printf("%s()\n", $1); }
     
%%

void parser(int argc, char* argv[])
{
  int token;
   
   if ( argc != 2 )
   {
      printf("Informe o arquivo de entrada\n");  
      getchar();
      return;
   }
  
   yyin = fopen( argv[1], "r" );
  
   if (yyin == NULL)
   {
      printf("Nao foi possivel abrir o arquivo %s\n", argv[1]);
      getchar();
      return;
   }

   if (yyparse() == 0)
   {
      printf("\nPrograma Compilado com Sucesso.\n");
   }
   else
   {
      printf("\n --> Arquivo %s - Erro de sintaxe na linha %d\n", argv[1], yyline);
   }
   
   encerraCompilacao();
}       

int main(int argc, char* argv[])
{
  parser(argc, argv);
  return 0;
}
