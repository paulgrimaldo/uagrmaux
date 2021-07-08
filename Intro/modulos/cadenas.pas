unit cadena; 

interface

function EsVocal(caracter: Char) : Boolean;
function CantidadEspacios(cadena: String) : Integer;
function CantidadPalabras(cadena: String) : Integer;
function CantidadLetras(cadena: String) : Integer;
function CantidadNumeros(cadena: String) : Integer;

implementation


var
  vocales: set of Char = ['a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'];
  alfabeto: set of 'a'..'z' ;
  numeros: set of 0..9;

function EsVocal(caracter: Char) : Boolean;
var resultado: Boolean;
begin
  resultado := false;
  if caracter in vocales then
    begin
      resultado := true;
    end ;
  EsVocal:=resultado;
end; 
function CantidadEspacios(cadena: String) : Integer;

var
  cantidad, i, longitud: Integer;


begin
  cantidad := 0;
  i := 1;
  longitud := Length(cadena);
  while i <= longitud do 
    begin
      if cadena[i] = ' ' then
        begin
          cantidad := cantidad + 1;
        end ;
      i := i + 1;
    end;
  CantidadEspacios := cantidad;
end; 
function CantidadPalabras(cadena: String) : Integer;

var
  cantidad, i, longitud, a: Integer;
  aux: String;


begin
  cantidad := 0;
  i := 1;
  a:=1;
  longitud := Length(cadena);
  while (i <= longitud) and (a > 0) do 
    begin
      a := Pos(' ', cadena);
      if a > 0 then
        begin
          cantidad := cantidad + 1;
          i := a + 1;
        end ;
    end;
  CantidadPalabras := cantidad + 1;
end; 
function CantidadLetras(cadena: String) : Integer;

var
  cantidad, i, longitud: Integer;


begin
  cantidad := 0;
  i := 1;
  longitud := Length(cadena);
  while (i <= longitud) do 
    begin
      if ((cadena[i]>= 'a') and (cadena[i]<='z')) or ((cadena[i]>= 'A') and (cadena[i]<='Z'))then
        begin
          cantidad := cantidad + 1;
        end ;
      i := i + 1;
    end;
  CantidadLetras := cantidad;
end; 
function CantidadNumeros(cadena: String) : Integer;

var
  c, i, n: Integer;


begin
  c := 0;
  i := 1;
  n := Length(cadena);
  while (i <= n) do 
    begin
      if Int(cadena[i]) in numeros then
        begin
          c := c + 1;
        end ;
      i := i + 1;
    end;
  CantidadNumeros := c;
end; 
end.
