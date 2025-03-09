if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACCOUNT') and o.name = 'FK_ACCOUNT_HAS5_CUSTOMER')
alter table ACCOUNT
   drop constraint FK_ACCOUNT_HAS5_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BRANCH') and o.name = 'FK_BRANCH_HAS1_BANK')
alter table BRANCH
   drop constraint FK_BRANCH_HAS1_BANK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUSTOMER_PHONE') and o.name = 'FK_CUSTOMER_HAS7_CUSTOMER')
alter table CUSTOMER_PHONE
   drop constraint FK_CUSTOMER_HAS7_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLOYEE') and o.name = 'FK_EMPLOYEE_WORKS_FOR_BANK')
alter table EMPLOYEE
   drop constraint FK_EMPLOYEE_WORKS_FOR_BANK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HAS2') and o.name = 'FK_HAS2_HAS2_CUSTOMER')
alter table HAS2
   drop constraint FK_HAS2_HAS2_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HAS2') and o.name = 'FK_HAS2_HAS3_BRANCH')
alter table HAS2
   drop constraint FK_HAS2_HAS3_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOAN') and o.name = 'FK_LOAN_HAS4_CUSTOMER')
alter table LOAN
   drop constraint FK_LOAN_HAS4_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOAN') and o.name = 'FK_LOAN_HAS6_EMPLOYEE')
alter table LOAN
   drop constraint FK_LOAN_HAS6_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOAN') and o.name = 'FK_LOAN_OFFER_BRANCH')
alter table LOAN
   drop constraint FK_LOAN_OFFER_BRANCH
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ACCOUNT')
            and   name  = 'HAS5_FK'
            and   indid > 0
            and   indid < 255)
   drop index ACCOUNT.HAS5_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACCOUNT')
            and   type = 'U')
   drop table ACCOUNT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BANK')
            and   type = 'U')
   drop table BANK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BRANCH')
            and   name  = 'HAS1_FK'
            and   indid > 0
            and   indid < 255)
   drop index BRANCH.HAS1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BRANCH')
            and   type = 'U')
   drop table BRANCH
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUSTOMER')
            and   type = 'U')
   drop table CUSTOMER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CUSTOMER_PHONE')
            and   name  = 'HAS7_FK'
            and   indid > 0
            and   indid < 255)
   drop index CUSTOMER_PHONE.HAS7_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUSTOMER_PHONE')
            and   type = 'U')
   drop table CUSTOMER_PHONE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EMPLOYEE')
            and   name  = 'WORKS_FOR_FK'
            and   indid > 0
            and   indid < 255)
   drop index EMPLOYEE.WORKS_FOR_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLOYEE')
            and   type = 'U')
   drop table EMPLOYEE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HAS2')
            and   name  = 'HAS3_FK'
            and   indid > 0
            and   indid < 255)
   drop index HAS2.HAS3_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HAS2')
            and   name  = 'HAS2_FK'
            and   indid > 0
            and   indid < 255)
   drop index HAS2.HAS2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HAS2')
            and   type = 'U')
   drop table HAS2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOAN')
            and   name  = 'OFFER_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOAN.OFFER_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOAN')
            and   name  = 'HAS6_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOAN.HAS6_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOAN')
            and   name  = 'HAS4_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOAN.HAS4_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOAN')
            and   type = 'U')
   drop table LOAN
go

create table ACCOUNT (
   ACCOUNTNO            int                  not null,
   SSN                  int                  not null,
   TYPE                 text                 null,
   BALANCE              decimal              not null,
   constraint PK_ACCOUNT primary key nonclustered (ACCOUNTNO)
)
go

create index HAS5_FK on ACCOUNT (
SSN ASC
)
go

create table BANK (
   BANKNAME             varchar(1024)        not null,
   BANKCODE             int                  not null,
   BANKADDRESS          text                 not null,
   constraint PK_BANK primary key nonclustered (BANKCODE)
)
go

create table BRANCH (
   BRANCHNO             int                  not null,
   BANKCODE             int                  not null,
   B_CITY               text                 not null,
   B_STATE              text                 null,
   B_STREET             text                 null,
   constraint PK_BRANCH primary key nonclustered (BRANCHNO)
)
go

create index HAS1_FK on BRANCH (
BANKCODE ASC
)
go

create table CUSTOMER (
   SSN                  int                  not null,
   FNAME                text                 not null,
   LNAME                text                 null,
   CITY                 text                 not null,
   STATE                text                 null,
   STREET               text                 null,
   constraint PK_CUSTOMER primary key nonclustered (SSN)
)
go

create table CUSTOMER_PHONE (
   PHONENO              char(15)             not null,
   C_SSN                int                  not null,
   SSN                  int                  not null,
   constraint PK_CUSTOMER_PHONE primary key nonclustered (PHONENO, C_SSN)
)
go

create index HAS7_FK on CUSTOMER_PHONE (
SSN ASC
)
go

create table EMPLOYEE (
   EMPLOYEEID           int                  not null,
   BANKCODE             int                  not null,
   E_FNAME              text                 not null,
   E_LNAME              text                 not null,
   constraint PK_EMPLOYEE primary key nonclustered (EMPLOYEEID)
)
go

create index WORKS_FOR_FK on EMPLOYEE (
BANKCODE ASC
)
go

create table HAS2 (
   SSN                  int                  not null,
   BRANCHNO             int                  not null,
   constraint PK_HAS2 primary key (SSN, BRANCHNO)
)
go

create index HAS2_FK on HAS2 (
SSN ASC
)
go

create index HAS3_FK on HAS2 (
BRANCHNO ASC
)
go

create table LOAN (
   LOANNO               int                  not null,
   BRANCHNO             int                  null,
   SSN                  int                  null,
   EMPLOYEEID           int                  null,
   LOANAMMOUNT          decimal              not null,
   LOANTYPE             text                 null,
   constraint PK_LOAN primary key nonclustered (LOANNO)
)
go

create index HAS4_FK on LOAN (
SSN ASC
)
go

create index HAS6_FK on LOAN (
EMPLOYEEID ASC
)
go


create index OFFER_FK on LOAN (
BRANCHNO ASC
)
go

alter table ACCOUNT
   add constraint FK_ACCOUNT_HAS5_CUSTOMER foreign key (SSN)
      references CUSTOMER (SSN)
go

alter table BRANCH
   add constraint FK_BRANCH_HAS1_BANK foreign key (BANKCODE)
      references BANK (BANKCODE)
go

alter table CUSTOMER_PHONE
   add constraint FK_CUSTOMER_HAS7_CUSTOMER foreign key (SSN)
      references CUSTOMER (SSN)
go

alter table EMPLOYEE
   add constraint FK_EMPLOYEE_WORKS_FOR_BANK foreign key (BANKCODE)
      references BANK (BANKCODE)
go

alter table HAS2
   add constraint FK_HAS2_HAS2_CUSTOMER foreign key (SSN)
      references CUSTOMER (SSN)
go

alter table HAS2
   add constraint FK_HAS2_HAS3_BRANCH foreign key (BRANCHNO)
      references BRANCH (BRANCHNO)
go

alter table LOAN
   add constraint FK_LOAN_HAS4_CUSTOMER foreign key (SSN)
      references CUSTOMER (SSN)
go

alter table LOAN
   add constraint FK_LOAN_HAS6_EMPLOYEE foreign key (EMPLOYEEID)
      references EMPLOYEE (EMPLOYEEID)
go

alter table LOAN
   add constraint FK_LOAN_OFFER_BRANCH foreign key (BRANCHNO)
      references BRANCH (BRANCHNO)
go