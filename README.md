# Tutorial Dot Net
  * Repo  นี้มีไว้สำหรับฝึก Dot  Net  โดยใช้งานโครงสร้าง Clean Code Architecture C# ซึ่งข้อดีสำหรับการทำงานด้วย  Clean Code  Architecture นั้นคือ
    * แบ่งการทำการงานของแต่ละส่วนออกมา
    * เพิ่มความยืดหยุ่น
    * ง่ายต่อการ  Maintain
  * Project ของ Clean Code Architecture นั้นจะประกอบไปด้วยกัน  4 Project หลักๆคือ
  
> Domain

  * เป็นส่วนที่เอาไว้เก็บข้อมูล POCO Database หรือ Entity Object Database

> Core

  * เป็นส่วนที่ทำงานเกี่ยวกับ  Bussiness  , Logic 

> Infrastructure

  *  เป็นส่วนที่เชื่อมต่อกับฐานข้อมูล
  * Config 
  * รวมทั้ง Migration
  * [Command Migrations เบื้องต้น](https://github.com/Suphanat-th/TutorialDotNet/blob/main/Migration.md "[Command Migrations เบื้องต้น]")

> UserInterface (Web  Application , API)

  * เป็นส่วนที่ผู้ใช้งานจะเข้ามาใช้งานตัวระบบ

### ความสำคัญของ Project
  * Level คือ อะไร

    * เป็นตัวแสดงความสำคัญ ยิ่ง  Level ยิ่งต่ำจะยิ่งมีผลกระทบกับ  Level ที่สูงขึ้น เช่น หากมีการแก้ไขที่ Level 1  จะเกิดผลกระทบกับ Level ที่มากกว่าที่ทำการแก้ไขไป

> DOMAIN

* Level 1

    * ลำดับความสำคัญที่มากที่สุด เป็นตัวเก็บหรือรวบรวมข้อมูลต่างๆ ของ Entity หรือ Poco database
    * จะไม่มีการ Reference Project อื่นๆ หรือ ติดต่อเรียก Level  อื่นๆ

> CORE

* Level 2

    * เป็นส่วนที่เก็บ Bussiness และ Logic
    * โดยตัว Core  จะมีการ Reference หรือ ติดต่อกับ  Level  อื่นๆ ดังนี้
      * Domain

> INFRASTRUCTURE

* Level 3

    * เป็นส่วนที่ migrations  และ  การสร้าง BaseContext เพื่อใช้ในการเชื่อมต่อ Database  รวมถึงการเชื่อมต่ออื่นๆ จากภายนอกจะถูก  Imprement ในส่วนนี้*
		* โดยตัว Infrastructure  จะมีการ Reference หรือ ติดต่อกับ  Level  อื่นๆ ดังนี้
      * Domain
      * Core

> USER INTERFACE

* Level 4

    * เป็นส่วนที่ผู้ใช้งานเข้ามาใช้งานระบบ โดยอาจจะเป็น Web Application หรือ  API ก็ตาม
		* โดยตัว User Interface  จะมีการ Reference หรือ ติดต่อกับ  Level  อื่นๆ ดังนี้
       * Core
       * Infrastructure