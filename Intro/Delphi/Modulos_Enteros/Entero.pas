unit Entero;

interface

var
  n: Integer;
function CantidadDigitos(): Integer;
procedure RegistrarN(nu: Integer);
function Invertir(): Integer;
function DigitoMayor(): Integer;
function DigitoMenor(): Integer;
function Ejercicio3(): Integer;
function Ejercicio5(): Integer;
function Ejercicio9(): Integer;
function Ejercicio13(): Integer;
function Ejercicio26(): Integer;
function Ejercicio27(): Integer;
// out se utiliza cuando quiero dar mas de 1 resultado, yo especifico donde tengo que colocar los resultados
procedure Ejercicio33(out sp, si: Integer);
function ContieneDigito(na, di: Integer): Boolean;

implementation

procedure RegistrarN(nu: Integer);
begin
  n := nu;
end;

function Invertir(): Integer;
var
  n1, nu, d: Integer;
begin
  n1 := n;
  nu := 0;

  while n1 > 0 do
  begin
    d := n1 mod 10;
    n1 := n1 div 10;

    nu := nu * 10 + d;
  end;

  Result := nu;
end;

function DigitoMayor(): Integer;
var
  n1, d, m: Integer;
begin
  n1 := n;
  m := n1 mod 10;

  while n1 > 0 do
  begin
    d := n1 mod 10;
    n1 := n1 div 10;

    if d > m then
      m := d;
  end;

  Result := m;
end;

function DigitoMenor(): Integer;
var
  n1, d, m: Integer;
begin
  n1 := n;
  m := n1 mod 10;

  while n1 > 0 do
  begin
    d := n1 mod 10;
    n1 := n1 div 10;

    if d < m then
      m := d;
  end;

  Result := m;
end;

function CantidadDigitos(): Integer;
var
  c, n1: Integer;
begin
  c := 0;
  n1 := n;
  while n1 > 0 do
  begin
    n1 := n1 div 10;
    c := c + 1;
  end;
  Result := c;
end;

// De un n?mero, eliminar el digito mayor y el digito menor, mostrar el resultado en otro numero
function Ejercicio3(): Integer;
var
  may, men, n1, nu, nr, d: Integer;
begin
  may := DigitoMayor;
  men := DigitoMenor;
  n1 := n;
  nr := 0;
  nu := 0;

  while n1 > 0 do
  begin
    d := n1 mod 10;
    n1 := n1 div 10;
    if (d <> may) and (d <> men) then
    begin
      nu := nu * 10 + d;
    end;
  end;
  // Invertimos en numero construido
  while nu > 0 do
  begin
    d := nu mod 10;
    nu := nu div 10;

    nr := nr * 10 + d;
  end;
  Result := nr;
end;

// De un n?mero natural, mostrar el digito del medio, si dicho numero tiene cantidad de d?gitos impares
function Ejercicio9(): Integer;
var
  n1, c, d, i, a, r: Integer;
begin
  n1 := n;
  c := CantidadDigitos();
  d := 0;

  if c mod 2 = 1 then
  begin
    i := (c div 2) + 1;
    a := 1;
    while a <= i do
    begin
      d := n1 mod 10;
      n1 := n1 div 10;
      a := a + 1;
    end;
    r := d;
    Result := r;
  end
  else
  begin
    r := -1;
  end;

  Result := r;
end;

// Hacer un programa para mostrar el primer digito par
function Ejercicio13(): Integer;
var
  d, n1: Integer;
begin
  n1 := Invertir();
  d := -1;

  while n1 > 0 do
  begin
    d := n1 mod 10;
    n1 := n1 div 10;

    if d mod 2 = 0 then
    begin
      n1 := 0;
    end;
  end;

  Result := d;
end;

// Hacer un programa que pida un numero por teclado y ordene los d?gitos de dicho numero de menor a mayor
function Ejercicio27(): Integer;
var
  n1, s, d, nu: Integer;
  c: Integer;
begin
  nu := 0;
  for c := 0 to 9 do
  begin
    n1 := n;
    while n1 > 0 do
    begin
      d := n1 mod 10;
      n1 := n1 div 10;
      if d = c then
      begin
        nu := nu * 10 + d;
      end;
    end;
  end;

  Result := nu;
end;

// Hacer un programa que sume los pares e impares por separado de un n?mero introducido
procedure Ejercicio33(out sp, si: Integer);
var
  n1, d: Integer;
begin
  sp := 0;
  si := 0;
  n1 := n;
  while n1 > 0 do
  begin
    d := n1 mod 10;
    n1 := n1 div 10;

    if d mod 2 = 0 then
      sp := sp + d
    else
      si := si + d;
  end;
end;

// Hacer un programa que pida un n?mero por teclado y determine cuantos d?gitos pares tiene a continuaci?n un digito impar
function Ejercicio26(): Integer;
var
  c, n1, d, d1: Integer;
begin
  n1 := n;
  c := 0;

  while n1 > 0 do
  begin
    d := n1 mod 10;
    n1 := n1 div 10;
    d1 := n1 mod 10;

    if (d mod 2 = 1) and (d1 mod 2 = 0) then
    begin
      c := c + 1
    end;
  end;

  Result := c;
end;

function ContieneDigito(na, di: Integer): Boolean;
var
  r: Boolean;
var
  d: Integer;
begin
  r := False;
  while na > 0 do
  begin
    d := na mod 10;
    na := na div 10;

    if d = di then
    begin
      r := True;
      na := 0;
    end;
  end;
  Result := r;
end;

// De un numero natural con d?gitos repetidos, mostrar otro n?mero con d?gitos ?nicos
function Ejercicio5(): Integer;
var
  n1, d, nu: Integer;
begin

  nu := 0;
  n1 := Invertir; // Si n = 2232214 entonces n1 = 4122322
  while n1 > 0 do
  begin
    d := n1 mod 10;
    n1 := n1 div 10;
    begin
      // ContieneDigito funcion auxiliar que me dice si nu contiene al digito d
      if Not ContieneDigito(nu, d) then
      begin
        nu := nu * 10 + d;
      end;

    end;
  end;

  Result := nu;
end;

end.
