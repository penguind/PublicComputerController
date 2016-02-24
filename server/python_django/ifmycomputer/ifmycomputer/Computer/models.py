#-*- coding:utf-8 -*-
from django.db import models

class Computer:
    '''This model record the info of every computer registed'''
    # id of record
    id = models.AutoField('ID', primary_key=True)
    # the name of computer being recorded
    nickname = models.CharField(max_length = 32)
    # the IP of this computer
    currentip = models.CharField(max_length = 15)
    # the IP of this computer before last changed
    lastip = models.CharField(max_length = 15)
    # the unque id of this computer(machine address)
    macaddr = models.CharField(max_length = 10)
    # introduction of this computer
    xtext = models.TextField(blank=True)
    # the first time this node is created
    createtime = models.DateTimeField(auto_now_add = True)

    def __str__(self):
        return "%s::%s:%s:%s:%s:%s" % (self.currentip,
                                       self.macaddr[0:2],
                                       self.macaddr[2:4],
                                       self.macaddr[4:6],
                                       self.macaddr[6:8],
                                       self.macaddr[8:])