#-*- coding:utf-8 -*-
from django.db import models

class User:
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
    createtime = models.DateTimeField(auto_now_add = True)

    def __str__(self):
        return "%s(%s)" % (self.nickname, self.name)