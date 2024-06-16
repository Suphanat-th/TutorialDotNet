# TutorialDotNet

#2023 12 14

- ViewModels and Login Example
  > https://stackoverflow.com/questions/11064316/what-is-viewmodel-in-mvc

* Html Helpers razor page
  > https://www.tutorialsteacher.com/mvc/html-helpers

# Concept

การทำงานจะแบ่งออกเป็น 2 ส่วนคือ Fontend , Backend

* Fontend ประกอบด้วย

  * Controller
  * Models
  * View
  * wwwroot

* Backend ประกอบด้วย

  * Database
    Database คือ ส่วนที่เอาไว้จัดการเกี่ยวกับฐานข้อมูลต่างๆ ประกอบด้วย

    - Configuration
      Configuration คือ Folder ที่เอาไว้สำหรับเก็บ File ที่จัดการตัว POCO Schema deatil ต่างๆ
    - DTOs
      DTOs คือ Folder สำหรับการเก็บ Class ที่เอาไว้กำหนด Schema ของฐานข้อมูล
    - Migrations
      Migrations คือ Folder สำหรับ Snapshot ในการสร้างหรืออัปเดตฐานข้อมูลแต่ละครั้ง
    - Repositories
      Repositories คือ Folder  ที่เก็บการทำงาน CRUD ในฝั่งของฐานข้อมูลโดยเฉพาะ โดย Dev  จะต้องสร้าง  Interface ขึ้นมารับจากฝั่งของหน้าบ้าน
    - DataContext.cs
      DataContext คือ File  ที่เอาไว้ทำการเชื่อมกับฐานข้อมูล โดยที่เราจะ  configuration และ  Imprement  table ใน File   นี้

  * Services
