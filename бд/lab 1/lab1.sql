select * from hr.locations;

select * from hr.departments;

select employees.first_name||' '|| employees.last_name, employees.hire_date, employees.salary 
from hr.employees;

select  employees.first_name, employees.last_name, employees.salary, NVL(employees.commission_pct, 0) 
from hr.employees;

select  employees.first_name, employees.last_name, employees.salary*12, jobs.job_id
from hr.employees, hr.jobs 
where employees.job_id=jobs.job_id;

select employees.first_name, employees.last_name, employees.commission_pct 
from hr.employees
where employees.commission_pct>0;

select employees.first_name, employees.last_name, employees.salary, employees.commission_pct,  (employees.salary+ employees.salary*employees.commission_pct)*12 annual_salary
from hr.employees
order by employees.commission_pct DESC nulls last;

select employees.first_name, employees.last_name, employees.salary 
from hr.employees, hr.jobs
where (employees.salary  between 2008 AND 4000) AND (employees.job_id=jobs.job_id);

select employees.first_name, employees.last_name, departments.department_name, employees.hire_date
from hr.employees, hr.departments
where employees.department_id=departments.department_id AND employees.hire_date LIKE '%2003';

select employees.first_name, employees.last_name
from hr.employees
where employees.last_name LIKE 'K%' OR employees.last_name LIKE 'L%' ;

select employees.first_name, employees.last_name 
from hr.employees
where NVL (employees.manager_id, 0) = 0;


select employees.first_name, employees.last_name, employees.salary*12 annual_salary, employees.salary*12-employees.salary*12*0.19 salary_without_tax
from hr.employees; 

select employees.first_name, employees.last_name, employees.salary 
from hr.employees, hr.jobs
where (employees.salary  between 5000 AND 6000) AND (employees.job_id=jobs.job_id);


select * from jobs
