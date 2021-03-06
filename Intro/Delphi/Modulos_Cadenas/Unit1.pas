unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants,
  System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.Menus;

type
  TForm1 = class(TForm)
    MainMenu1: TMainMenu;
    TxtCad: TEdit;
    TxtResultado: TEdit;
    Ejercicios1: TMenuItem;
    Ejercicio121: TMenuItem;
    Edit1: TEdit;
    BtnRegistrar: TButton;
    Ejercicio12V21: TMenuItem;
    Button1: TButton;
    Ejercicio91: TMenuItem;
    Ejercicio191: TMenuItem;
    Ejercicio201: TMenuItem;
    Ejercicio141: TMenuItem;
    Ejercicio161: TMenuItem;
    Ejercicio171: TMenuItem;
    procedure BtnRegistrarClick(Sender: TObject);
    procedure Ejercicio121Click(Sender: TObject);
    procedure Ejercicio12V21Click(Sender: TObject);
    procedure Button1Click(Sender: TObject);
    procedure Ejercicio91Click(Sender: TObject);
    procedure Ejercicio191Click(Sender: TObject);
    procedure Ejercicio201Click(Sender: TObject);
    procedure Ejercicio141Click(Sender: TObject);
    procedure Ejercicio161Click(Sender: TObject);
    procedure Ejercicio171Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  cad: String;
  n: Integer;

const
  conso: set of char = ['A' .. 'Z'] - ['A', 'E', 'I', 'O', 'U', 'a', 'e', 'i',
    'o', 'u'];
  voc: set of char = ['A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u'];

implementation

{$R *.dfm}

procedure TForm1.BtnRegistrarClick(Sender: TObject);
begin
  cad := TxtCad.Text;
  n := Length(cad);
end;

procedure TForm1.Button1Click(Sender: TObject);
begin
  TxtResultado.Text := IntToStr(n);
end;

// Copiar un subcadena en una cadena de caracteres y mostrar la cadena completa
procedure TForm1.Ejercicio121Click(Sender: TObject);
var
  subCad: String;
begin
  subCad := Edit1.Text;
  cad := Concat(cad, ' ', subCad);
  TxtResultado.Text := cad;
end;

// Copiar un subcadena en una cadena de caracteres y mostrar la cadena completa
procedure TForm1.Ejercicio12V21Click(Sender: TObject);
var
  subCad, antP, postP: String;
  p, l1: Integer;
begin
  p := StrToInt(InputBox('Ingresa posicion', '', ''));
  subCad := Edit1.Text;
  // SubString - Copia desde el  indice x, y caracteres
  { antP := cad.Substring(0, p);
    postP := cad.Substring(p);
    cad := Concat(antP, subCad, postP);
    TxtResultado.Text := cad; }
  cad := cad.Insert(p, subCad);
  TxtResultado.Text := cad;
end;

// Elaborar un programa que convierta a may?scula el primer car?cter de cada palabra que exista en una cadena introducida por teclado
procedure TForm1.Ejercicio141Click(Sender: TObject);
var
  i: Integer;
begin
  i := 1;
  while i <= n do
  begin
    if cad[i] <> ' ' then
    begin
      cad[i] := UpCase(cad[i]);

      while (i <= n) and (cad[i] <> ' ') do
      begin
        i := i + 1;
      end;
    end;

    i := i + 1;
  end;

  TxtResultado.Text := cad;
end;

// Elaborar un programa que elimine la palabra numero k (l es un numero introducida por teclado) de una cadena de caracteres introducida por teclado.
procedure TForm1.Ejercicio161Click(Sender: TObject);
var
  i, a, c, x, k: Integer;
begin
  i := 1;
  a := 1;
  c := 0; // Contador de caracteres por palabra
  x := 0; // Contador de palabras
  k := StrToInt(InputBox('Ingresar K', '', ''));

  while i <= n do
  begin
    if cad[i] <> ' ' then
    begin
      a := i;
      c := 0;

      while (i <= n) and (cad[i] <> ' ') do
      begin
        i := i + 1;
        c := c + 1;
      end;
      x := x + 1;
      if x = k then
      begin
        Delete(cad, a, c);
      end;
    end;

    i := i + 1;
  end;
  TxtResultado.Text := cad;
end;

// Elaborar un programa que elimine tosas las palabras de un cadena de caracteres que tengan delante de ellas una palabra con la consonante ?c?
procedure TForm1.Ejercicio171Click(Sender: TObject);
var
  a, i, c: Integer;
  contieneC: Boolean;
begin
  i := 1;
  a := 1; // indice donde comienza cada palabra
  c := 0; // Cantidad de caracteres por palabra

  while i <= n do
  begin
    if cad[i] <> ' ' then
    begin
      a := i;
      contieneC := False;
      c := 0;
      if (UpCase(cad[a]) = 'C') then
      begin
        contieneC := True;
      end;
      while (i <= n) and (cad[i] <> ' ') do
      begin
        i := i + 1;
        c := c + 1;
      end;

      if (contieneC = True) then
      begin
        Delete(cad, a, c);
      end;
    end;

    i := i + 1;
  end;

  TxtResultado.Text := cad;
end;

// Elaborar un programa que invierta  una cadena de caracteres introducida por teclado
procedure TForm1.Ejercicio191Click(Sender: TObject);
var
  i: Integer;
var
  cadAux: String;
begin
  i := n;
  cadAux := '';

  while i >= 1 do
  begin
    cadAux := Concat(cadAux, cad[i]);
    i := i - 1;
  end;
  cad := cadAux;
  TxtResultado.Text := cad;
end;

// Elaborar un programa que invierta la segunda palabra de una cadena de caracteres introducida por teclado.
procedure TForm1.Ejercicio201Click(Sender: TObject);
var
  a, i, j, c: Integer;
  s: char;
begin

  a := 0;
  i := 1;
  j := 0;
  c := 0;
  while (i <= n) do
  begin
    // comienza la palabra
    if cad[i] <> ' ' then
    begin
      a := i;

      while (i <= n) and (cad[i] <> ' ') do
      begin
        // avanzo hasta donde finaliza la palabra
        i := i + 1;
      end;
      // termina la palabra
      j := i - 1;
      c := c + 1;

      if (c = 2) then
      begin
        // invertir entre a y j
        while a < j do
        begin
          s := cad[a];
          cad[a] := cad[j];
          cad[j] := s;

          a := a + 1;
          j := j - 1;
        end;
      end;
    end;
    i := i + 1;
  end;
  TxtResultado.Text := cad;
end;

// Contar las veces que se repiten en una cadena 2 consonantes juntas
procedure TForm1.Ejercicio91Click(Sender: TObject);
var
  c, i, j: Integer;
begin

  i := 1;
  j := i + 1;
  c := 0;
  while (i <= n - 1) do
  begin
    if UpCase(cad[i]) in conso then
    begin
      if UpCase(cad[j]) in conso then
      begin
        if UpCase(cad[i]) = UpCase(cad[j]) then
        begin
          c := c + 1;
        end;

      end;
    end;
    i := i + 1;
    j := j + 1;
  end;

  TxtResultado.Text := IntToStr(c);
end;

end.
