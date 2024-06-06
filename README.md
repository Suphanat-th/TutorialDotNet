# TutorialDotNet

# ViewModels and Login Example

    > https://stackoverflow.com/questions/11064316/what-is-viewmodel-in-mvc

# Html Helpers razor page

    > https://www.tutorialsteacher.com/mvc/html-helpers

# Linq

    * SELECT
      * คือการเลือกข้อมูล โดยตัวอย่างคือ  ListofUser.Select(x=>x);
    * Where
      * คือการที่ต้องการหาหรือใส่  condition ที่ต้องการลงไปใน Where เช่น ListofUser.Where(x=>x ==  \"admin\")
    *OrderBy , OrderByDescending
      * คือการจัดเรียงข้อมูลที่ต้องการ เช่น ListofUser.OrderBy(x=>x);

# Clean Code Architecture

    * การแบ่ง Tier Project โดยนิยามว่า Deep Level
    * Deep  Level คือ Level  ของตัว  Project
      * High Level  = Level  แรกที่เชื่อมต่อกับ User Interface  หรือ ตัว Application
      * หากแก้ไขที่ Level ไหนผลกระทบจะเกิดขึ้นกับ High Level  ที่ทำการแก้ไข เช่น   หากต้องการแก้ไข Level  ที่ 3  จะกระทบกับ Level ที่ 5 และ 4  หากแก้ไขที่ระดับ Level  ที่ 1  จะเกิดผลกระทบกับ  Level  ที่ 5 , 4, 3 ,2  และ  1

# Dependency Injection Services Life Time

    * AddTransient  = ทุกครั้งที่ Call Class จะถูกใช้สร้างใหม่ตลอด
    * AddScope = ทุกครั้งที่ Client Request จะถูกสร้างใหม่ คล้ายๆ Sessions
    * AddSingleton = ทุกครั้งที่เรียกจะได้ค่าเดิมเสมอ ไม่ว่า Client Request  จะถูกเข้ามากีรอบ
