/*
This file in the main entry point for defining grunt tasks and using grunt plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkID=513275&clcid=0x409
*/
module.exports = function (grunt) {
    // load Grunt plugins from NPM
    grunt.loadNpmTasks("grunt-contrib-copy");

    grunt.initConfig({
        copy: {
            files: {
                cwd: 'bower_components/',
                src: ['**/*.*'],
                dest: 'wwwroot/bower_components/',
                expand: true
            }
        },
    });

    // define tasks
    grunt.registerTask('default', ['copy']);
};