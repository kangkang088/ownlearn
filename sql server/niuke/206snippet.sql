select 
  t1.dept_no,t2.emp_no,t1.salary 
from 
  (select 
    d.dept_no,max(s.salary) salary 
  from 
    dept_emp d
  join 
    salaries s
  on 
    d.emp_no=s.emp_no and d.to_date='9999-01-01' and s.to_date='9999-01-01'
  group by 
    d.dept_no) t1
join 
  (select 
    d.emp_no,d.dept_no,s.salary 
  from 
    dept_emp d
  join 
    salaries s
  on 
    d.emp_no=s.emp_no and d.to_date='9999-01-01' and s.to_date='9999-01-01') t2
on 
  t1.dept_no=t2.dept_no and t1.salary=t2.salary
order by 
  t1.dept_no;