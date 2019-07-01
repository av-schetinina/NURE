SELECT SUBSTR('Intelligent Desision Support Systems',1,11)
||' '
|| SUBSTR('Intelligent Desision Support Systems',-7,7) 
AS ExtractString
FROM DUAL

SELECT INSTR('initializations','it')
AS ExtractString
FROM DUAL

SELECT TO_CHAR(sysdate,'dd mm yyyy')"Today" FROM dual;
SELECT TO_CHAR(sysdate,'dd mon yyyy')"Today" FROM dual;
SELECT TO_CHAR(sysdate,'dd Month yyyy')"Today" FROM dual;

select TO_DATE('31 12 1998', 'dd mm yyyy') as dateOfBirth from dual;

select employees.first_name, employees.last_name, employees.hire_date,FLOOR((sysdate - employees.hire_date)/365 ) years
from hr.employees
where FLOOR(MONTHS_BETWEEN(sysdate, employees.hire_date)/12 )>=10;

select departments.department_name, FLOOR(AVG(employees.salary)) 
from hr.departments, hr.employees
where employees.department_id = departments.department_id
group by departments.department_name
order by departments.department_name asc;

select count(employees.employee_id) countOfEmployees
from hr.employees;

select departments.department_name, count(employees.employee_id)
from hr.employees, hr.departments
where employees.department_id = departments.department_id
group by departments.department_name;

select employees.first_name, employees.last_name, employees.department_id
from hr.employees
where NVL(employees.department_id,0)=0;

select departments.department_name, sum(employees.salary) 
from hr.departments, hr.employees
where employees.department_id = departments.department_id
GROUP BY departments.department_name
order by departments.department_name asc; 

select employees.first_name||' '||employees.last_name,departments.department_name, 
decode(employees.commission_pct, null, 'false', 'true') commision,employees.commission_pct
from hr.employees, hr.departments
where employees.department_id = departments.department_id;

select count(employees.employee_id)
from hr.employees
where employees.salary*6>50000;

select employees.first_name, employees.last_name, employees.hire_date
from hr.employees
where extract(month from employees.hire_date) in (4,5,6)

select employees.first_name, employees.last_name, employees.department_id
from hr.employees
where employees.department_id in (10,60,240,210);

select employees.first_name, employees.last_name, employees.department_id
from hr.employees
where employees.department_id=10 or employees.department_id=60
or employees.department_id=210 or employees.department_id=240;

select departments.department_name, count(employees.employee_id) emp from  hr.departments left outer join hr.employees
on employees.department_id=departments.department_id
having count(employees.employee_id)=0
group by departments.department_name
        
select departments.department_name, LENGTH(departments.department_name) len
from hr.departments
where LENGTH(departments.department_name)=(select max(LENGTH(departments.department_name))from hr.departments) 
or LENGTH(departments.department_name)=(select min(LENGTH(departments.department_name))from hr.departments) ;

select * from (select departments.department_name, FLOOR(AVG(employees.salary)) salary
from hr.departments, hr.employees
where employees.department_id = departments.department_id
group by departments.department_name
order by  FLOOR(AVG(employees.salary)) desc )
where rownum=1;

select LENGTH(REPLACE('Я являюсь студентом КИУ', ' ', '  ')) - LENGTH('Я являюсь студентом КИУ')len
from dual;

select employees.first_name||' '||employees.last_name "Фамилия имя" , jobs.job_title Должность, 
employees.phone_number "Номер телефона", departments.department_name Отдел
from hr.employees, hr.departments, hr.jobs
where employees.job_id=jobs.job_id and employees.department_id=departments.department_id and employees.employee_id=101;

select departments.department_name, count (employees.commission_pct) comm_pct
from hr.employees join hr.departments on employees.department_id=departments.department_id
having count(employees.employee_id)=(select max(count(employees.employee_id)) from hr.employees
where employees.commission_pct is not null 
group by employees.department_id)
group by departments.department_name;

select employees.employee_id, departments.department_name,e.manager_id, d.department_name
from hr.employees, hr.departments, departments d, employees e
where employees.manager_id=e.employee_id
and departments.department_id!=d.department_id
and employees.department_id=departments.department_id
and e.department_id=d.department_id

/*22*/
select locations.street_address, count(departments.department_id) employees,
from hr.locations  outer join hr.departments on departments.location_id=locations.location_id
group by locations.street_address

(select count(employees.employee_id) from hr.employees right outer join hr.departments
on employees.department_id=departments.department_id group by employees.department_id)



select employees.last_name "Фамилия",employees.first_name "Имя", departments.department_name "Отдел", countries.country_name "Страна"
from hr.employees, hr.departments, hr.countries, hr.locations
where employees.department_id=departments.department_id and departments.location_id=locations.location_id and locations.country_id=countries.country_id
order by departments.department_name desc, employees.last_name asc;

select  jobs.job_title, employees.salary, employees.last_name||' '||employees.first_name employee
from hr.employees, hr.jobs
where employees.job_id=jobs.job_id 
and (employees.job_id, employees.salary) in (select employees.job_id, max(employees.salary) 
from hr.employees
group by employees.job_id)
order by jobs.job_title asc;

