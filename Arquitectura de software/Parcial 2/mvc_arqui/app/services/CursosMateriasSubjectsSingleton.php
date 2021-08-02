<?php

class CursosMateriasSubjectsSingleton
{
    private static ?CursosMateriasSubjectsSingleton $instance = null;
    private array $subjects;


    private function __construct()
    {
        $this->subjects = array();
    }

    private function __clone()
    {
    }

    public function getSubjects(): array
    {
        return $this->subjects;
    }

    public static function getInstance(): CursosMateriasSubjectsSingleton
    {
        if (static::$instance === null) {
            static::$instance = new static();
        }
        return self::$instance;
    }

    public function getCursoMateriaSubject($cursoMateriaId)
    {
        foreach ($this->subjects as $subject) {
            if ($subject->getCursoMateria()->id == $cursoMateriaId) {
                return $subject;
            }
        }
        return null;
    }

    public function addCursoMateriaSubject(TareaObservable $tareaObservable)
    {
        array_push($this->subjects, $tareaObservable);
    }
}