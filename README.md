# TutorialDotNet

#2023 12 14

- ViewModels and Login Example
  > https://stackoverflow.com/questions/11064316/what-is-viewmodel-in-mvc

* Html Helpers razor page
  > https://www.tutorialsteacher.com/mvc/html-helpers

# อธิบาย

UserInterface (Web Application, API) -> Core ->Infrastructure ->Domain

Deep Level คือ ในแต่ละ  Level การสื่อสารกันจะติดต่อสื่อสารและ Implement Logic กันผ่าน Interface 

  * User  Interface

    User  Interface หรือส่วนที่ผู้ใช้งานทำการกระทำต่อระบบ เช่น  Web Application หรือ Api นั้นเอง

  * Core

    Core คือ ส่วนที่ทำการกำหนด หรือ พัฒนา Logic โดยจะส่งคืน Bussiness  Logic กลับไปให้ UI ในการแสดงผล  ซึ่งในส่วนนี้จะไม่มีการเชื่อมต่อหรือทำอะไรเกี่ยวกับการเชื่อมต่อต่างๆ

  * Infrastructure

    Infrastructure คือ ส่วนที่ใช้ในการติดต่อสื่อสารต่างๆกับ ภายนอกเช่น Database , API อื่นๆ , Caching หรือ Linenoti เป็นต้น

  * Domain

    Domain คือ  ตัวกำหนด Poco หรือ Event  ในการเชื่อมต่อกับภายนอก