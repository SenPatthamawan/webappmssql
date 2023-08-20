# webappmssql

#POCO = Plain old CLR object
สร้าง class POCO มาใช้ connect กับตาราง *ตั้งชื่อเหมือนกัน (ใน class จะมีแค่ properties)
โดยส่วนใหญ่มักจะสร้าง folder Data -> Entity -> POCO เพื่อเอาไป map กับตาราง

การเรียกใช้งาน class POCO จะเรียกผ่าน context จะสามารถเข้าถึงได้จากทุกที่ //=DTO? หาข้อมูลเพิ่ม
สร้าง class context ไว้ที่ folder Data (ใช้ชื่อเดียวกันกับ Database +context)
จะเป็น class กลางที่เอาไว้สื่อสารกับทุกๆจุดในตัวแอป

#Challenge
-ใช้กับ Database ตัวอื่น
-เพิ่มตาราง
-