<?php

class Alumno extends AbstractModel
{

    public $id;
    public $nombre;
    public $ci;
    public $email;


    public function __construct($id, $nombre, $ci, $email)
    {
        $this->id = $id;
        $this->nombre = $nombre;
        $this->ci = $ci;
        $this->email = $email;
    }

    public function getSaveSql($db)
    {
        $sql = $db->prepare("INSERT INTO alumnos (nombre, ci, email) values(?, ?,?)");
        $sql->bindParam(1, $this->nombre, PDO::PARAM_STR, 50);
        $sql->bindParam(2, $this->ci, PDO::PARAM_STR, 50);
        $sql->bindParam(3, $this->email, PDO::PARAM_STR, 50);

        return $sql;
    }

    public function setModelId()
    {
        $db = Db::getInstance();
        $this->id = $db->lastInsertId();
    }

    public static function exists($ci)
    {
        $db = Db::getInstance();
        $sql = 'SELECT * FROM alumnos WHERE ci="' . $ci . '"';
        $req = $db->query($sql);
        return $req->fetchAll();
    }

    public static function all()
    {
        $db = DB::getInstance();
        $req = $db->query('SELECT * FROM alumnos');
        return $req->fetchAll();
    }
}