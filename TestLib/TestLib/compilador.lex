%{

   int yyline = 1;
   
%}

%%
[a-zA-Z]([a-zA-Z]|[0-9])*         { 
                                     yylval = (char*) malloc (strlen(yytext) + 1);
                                     strcpy(yylval, yytext);
                                     return IDENTIFICADOR;
                                  }
[();]                             { return yytext[0];      }
[ \t\r]                           { /* espaço em branco*/  }
[\n]                              { yyline++;              }
.                                 {
                                     printf("Erro Lexico --> Linha: %d --> caractere invalido: %s\n", yyline, yytext);
                                     exit(0); // o compilador pára no primeiro erro.
                                  }
%%
