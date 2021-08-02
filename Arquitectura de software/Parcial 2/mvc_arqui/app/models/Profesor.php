<?php

class Profesor extends AbstractModel
{
    public $id;
    public $nombre;
    public $codigo;


    public function __construct($id, $nombre, $codigo)
    {
        $this->id = $id;
        $this->nombre = $nombre;
        $this->codigo = $codigo;
    }


    public function getSaveSql($db)
    {
        $sql = $db->prepare("INSERT INTO profesores (nombre,codigo) values(?,?)");
        $sql->bindParam(1, $this->nombre, PDO::PARAM_STR, 50);
        $sql->bindParam(2, $this->codigo, PDO::PARAM_STR, 50);

        return $sql;
    }

    public function setModelId()
    {
        $db = Db::getInstance();
        $this->id = $db->lastInsertId();
    }

    public static function exists($codigo)
    {
        $db = Db::getInstance();
        $sql = 'SELECT * FROM profesores WHERE codigo="' . $codigo . '"';
        $req = $db->query($sql);
        return $req->fetchAll();
    }

    public static function all()
    {
        $db = DB::getInstance();
        $req = $db->query('SELECT * FROM profesores');
        return $req->fetchAll();
    }
}