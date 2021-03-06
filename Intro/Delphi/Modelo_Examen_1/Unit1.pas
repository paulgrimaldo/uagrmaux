unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants,
  System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.Menus, Vcl.StdCtrls;

type
  TForm1 = class(TForm)
    MainMenu1: TMainMenu;
    TxtDato: TEdit;
    TxtResultado: TEdit;
    Ejercicios1: TMenuItem;
    VerificarOrdenado1: TMenuItem;
    EliminarVocales1: TMenuItem;
    Sumatoria1: TMenuItem;
    Invertirultimapalabra1: TMenuItem;
    procedure VerificarOrdenado1Click(Sender: TObject);
    procedure EliminarVocales1Click(Sender: TObject);
    procedure Sumatoria1Click(Sender: TObject);
    procedure Invertirultimapalabra1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.EliminarVocales1Click(Sender: TObject);
var
  cad: String;
  i, longitud: Integer;
const
  voc = ['A', 'E', 'I', 'O', 'U'];
begin
  i := 1;
  cad := TxtDato.Text;
  longitud := Length(cad);

  while i <= longitud do
  begin
    if UpCase(cad[i]) in voc then
    begin
      Delete(cad, i, 1);
    end;

    i := i + 1;
  end;

  TxtResultado.Text := cad;
end;

procedure TForm1.Invertirultimapalabra1Click(Sender: TObject);
var
  cad: String;
  x: Char;
  i, j, c: Integer;
begin
  cad := TxtDato.Text;
  i := Length(cad);
  j := 0;
  c := i;

  while i >= 1 do
  begin
    if cad[i] <> ' ' then
    begin
      c := i;

      while (cad[i] <> ' ') and (i >= 1) do
      begin
        i := i - 1;
      end;

      j := i + 1;

      while j < c do
      begin
        x := cad[j];
        cad[j] := cad[c];
        cad[c] := x;

        j := j + 1;
        c := c - 1;
      end;

      i := 0;
    end;

    i := i - 1;
  end;

  TxtResultado.Text := cad;
end;

procedure TForm1.Sumatoria1Click(Sender: TObject);
var
  f: Real;
  n, b: Integer;
begin
  f := 0;
  n := StrToInt(TxtDato.Text);
  b := 1;

  while n >= 1 do
  begin
    f := f + (n / b);

    n := n - 1;
    b := b + 1;
  end;

  TxtResultado.Text := FloatToStr(f);
end;

procedure TForm1.VerificarOrdenado1Click(Sender: TObject);
var
  n, d, d1: Integer;
  b: Boolean;
begin
  n := StrToInt(TxtDato.Text);

  d := n mod 10;
  n := n div 10;
  b := True;

  while (n > 0) and (b = True) do
  begin
    d1 := n mod 10;
    n := n div 10;
    if d1 > d then
    begin
      b := false;
    end;
    d := d1;
  end;

  if b = True then
  begin
    TxtResultado.Text := 'Esta ordenado';
  end
  else
  begin
    TxtResultado.Text := 'No esta ordenado';
  end;
end;

end.
