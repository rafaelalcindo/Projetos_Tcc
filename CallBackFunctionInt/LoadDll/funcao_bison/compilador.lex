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
[ \t\r]                           { /* espa�o em branco*/  }
[\n]                              { yyline++;              }
.                                 {
                                     printf("Erro Lexico --> Linha: %d --> caractere invalido: %s\n", yyline, yytext);
                                     exit(0); // o compilador p�ra no primeiro erro.
                                  }
%%
