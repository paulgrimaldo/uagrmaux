unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants,
  System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.Menus, Vcl.StdCtrls, Math;

type
  TForm1 = class(TForm)
    Edit1: TEdit;
    Edit2: TEdit;
    MainMenu1: TMainMenu;
    Eliminarrepetidos1: TMenuItem;
    Eliminarrepetidos2: TMenuItem;
    Ordenardigitos1: TMenuItem;
    procedure Eliminarrepetidos2Click(Sender: TObject);
    procedure Ordenardigitos1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

function Existe(n, d: Integer): Boolean;
var
  b: Boolean;
  a: Integer;
begin
  b := False;
  if (n = 0) and (d = 0) then
  begin
    b := True;
  end;

  while n > 0 do
  begin
    a := n mod 10;
    n := n div 10;

    if a = d then
    begin
      b := True;
      n := 0;
    end;
  end;
  Result := b;
end;

procedure TForm1.Eliminarrepetidos2Click(Sender: TObject);
var
  n, d, nu, i: Integer;
  b: Boolean;
begin
  n := StrToInt(Edit1.Text);
  d := 0;
  nu := 0;
  i := 0;

  while n > 0 do
  begin
    d := n mod 10;
    n := n div 10;
    b := Existe(nu, d);
    if b = False then
    begin
      nu := d * Round(Power(10, i)) + nu;
      i := i + 1;
    end;

  end;

  Edit2.Text := IntToStr(nu);
end;

// Ordenar los digitos de un numero de menor a mayor
procedure TForm1.Ordenardigitos1Click(Sender: TObject);
var
  n, n1, s, d, nu, c: Integer;
begin
  n := StrToInt(Edit1.Text);
  nu:=0;
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

  Edit2.Text := IntToStr(nu);
end;

end.
