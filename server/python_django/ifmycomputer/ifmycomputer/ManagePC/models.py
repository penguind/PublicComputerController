#-*- coding:utf-8 -*-
from django.db import models

class User(models.Model):
    '''This model record the info of user registed'''
    # id of record
    id = models.AutoField('ID', primary_key=True)
    # the name of user
    name = models.CharField(max_length = 32)
    # the nick name of user
    nickname = models.CharField(max_length = 32)
    # the password of user
    passwd = models.CharField(max_length = 32)
    # if this user is denied to get access of computers
    # "T" means he has no access power; "F" means accessable
    deny = models.CharField(max_length = 1)
    # the first time this user account is created
    createTime = models.DateTimeField(auto_now_add = True)

    def __str__(self):
        return "%s(%s)" % (self.nickname, self.name)


class Computer(models.Model):
    '''This model record the info of every computer registed'''
    # id of record
    id = models.AutoField('ID', primary_key=True)
    # the name of computer being recorded
    nickname = models.CharField(max_length = 32)
    # the IP of this computer
    currentIP = models.CharField(max_length = 15)
    # the IP of this computer before last changed
    lastIP = models.CharField(max_length = 15)
    # the unique id of this computer(the id of CPU, support one CPU(on physics))
    uniqueKey = models.CharField(max_length = 30)
    # introduction of this computer
    xtext = models.TextField(blank=True)
    # the first time this node is created
    createTime = models.DateTimeField(auto_now_add = True)

    def __str__(self):
        return "%s::%s:%s:%s:%s:%s" % (self.currentip,
                                       self.macaddr[0:2],
                                       self.macaddr[2:4],
                                       self.macaddr[4:6],
                                       self.macaddr[6:8],
                                       self.macaddr[8:])


class ResourceApply(models.Model):
    '''The application of resource, who is using, when it applied, etc..'''
    # id of record
    id = models.AutoField('ID', primary_key=True)
    # the id of computer
    computer = models.ForeignKey(Computer)
    # the user who applys the computer
    user = models.ForeignKey(User)
    # the first time this user account is created
    applyTime = models.DateTimeField()
    # the start time of applied
    startTime = models.DateTimeField()
    # the end time of applied
    endTime = models.DateTimeField()

    def __str__(self):
        return ""

class ResourceStatue(models.Model):
    '''The statue of resource, when it login, if it's busy(s.b. logged in), etc..'''
    # id of record
    id = models.AutoField('ID', primary_key=True)
    # the id of computer
    computer = models.ForeignKey(Computer)
    # the last user who logged in the computer
    user = models.ForeignKey(User)
    # the last time user logged in
    lastLoginTime = models.DateTimeField()

    def __str__(self):
        return ""