<?php

class CursoMateria extends AbstractModel
{
    public $id;
    public $cursoId;
    public $materiaId;
    public $profesorId;

    public function __construct($id, $cursoId, $materiaId, $profesorId)
    {
        $this->id = $id;
        $this->cursoId = $cursoId;
        $this->materiaId = $materiaId;
        $this->profesorId = $profesorId;
    }

    public function getSaveSql($db)
    {
        $sql = $db->prepare("INSERT INTO cursos_materias (materia_id,curso_id, profesor_id) values(?, ?,?)");
        $sql->bindParam(1, $this->materiaId, PDO::PARAM_INT);
        $sql->bindParam(2, $this->cursoId, PDO::PARAM_INT);
        $sql->bindParam(3, $this->profesorId, PDO::PARAM_INT);

        return $sql;
    }

    public function setModelId()
    {
        $db = Db::getInstance();
        $this->id = $db->lastInsertId();
    }

    public static function all()
    {
        $db = DB::getInstance();
        $req = $db->query('SELECT cm.id,m.nombre,c.nombre, p.nombre FROM cursos_materias cm join cursos c on
 c.id = cm.curso_id join materias m on m.id = cm.materia_id join profesores p on p.id = cm.profesor_id');
        return $req->fetchAll();
    }
}