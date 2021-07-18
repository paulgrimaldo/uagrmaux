unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants,
  System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.Menus, Entero;

type
  TForm1 = class(TForm)
    MainMenu1: TMainMenu;
    Er1: TMenuItem;
    Ejercicios1: TMenuItem;
    TxtNumero: TEdit;
    TxtResultado: TEdit;
    Button1: TButton;
    Ejercicio131: TMenuItem;
    Ordenar1: TMenuItem;
    Ejercicio31: TMenuItem;
    Ejercicio331: TMenuItem;
    Ejercicio261: TMenuItem;
    Ejercicio51: TMenuItem;
    procedure Button1Click(Sender: TObject);
    procedure Ejercicios1Click(Sender: TObject);
    procedure Ejercicio131Click(Sender: TObject);
    procedure Ordenar1Click(Sender: TObject);
    procedure Ejercicio31Click(Sender: TObject);
    procedure Ejercicio331Click(Sender: TObject);
    procedure Ejercicio261Click(Sender: TObject);
    procedure Ejercicio51Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);
begin
  RegistrarN(StrToInt(TxtNumero.Text));
end;

procedure TForm1.Ejercicio131Click(Sender: TObject);
var
  r: Integer;
begin
  r := Ejercicio13();
  TxtResultado.Text := IntToStr(r);
end;

procedure TForm1.Ejercicio261Click(Sender: TObject);
var
  r: Integer;
begin
  r := Ejercicio26();
  TxtResultado.Text := IntToStr(r);
end;

procedure TForm1.Ejercicio31Click(Sender: TObject);
var
  r: Integer;
begin
  r := Ejercicio3();
  TxtResultado.Text := IntToStr(r);
end;

procedure TForm1.Ejercicio331Click(Sender: TObject);
var
  sp, si: Integer;
begin
  sp := 0;
  si := 0;
  Ejercicio33(sp, si);
  TxtResultado.Text := 'SumaPares: ' + IntToStr(sp) + ', SumaImpares: ' +
    IntToStr(si);
end;

procedure TForm1.Ejercicio51Click(Sender: TObject);
var
  r: Integer;
begin
  r := Ejercicio5();
  TxtResultado.Text := IntToStr(r);
end;

procedure TForm1.Ejercicios1Click(Sender: TObject);
var
  r: Integer;
begin
  r := Ejercicio9();
  TxtResultado.Text := IntToStr(r);
end;

procedure TForm1.Ordenar1Click(Sender: TObject);
var
  r: Integer;
begin
  r := Ejercicio27;
  TxtResultado.Text := IntToStr(r);
end;

end.
