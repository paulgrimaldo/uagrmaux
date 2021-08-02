<?php

class PagesController
{
    public function home()
    {
        require_once('../app/views/pages/home.php');
    }

    public function error404()
    {
        require_once('../app/views/pages/404.html');
    }

    public function error500()
    {
        require_once('../app/views/pages/500.html');
    }
}