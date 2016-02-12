#! /bin/python
# -*- coding:utf-8 -*-

import web

class index(object):
    """docstring for index"""
    def GET(self):
        return "Hello world!"

class Icon(object):
    """Icon of website"""
    def GET(self):
        raise web.seeother("/static/res/favicon.ico")

urls = (
    '/', 'index',
    '/favicon.ico', 'Icon',
    )

if __name__ == "__main__":
    appweb = web.application(urls, globals())
    appweb.run()
        