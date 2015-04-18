var gulp = require('gulp'),
	coffee = require('gulp-coffee'),
	coffeelint = require('gulp-coffeelint'),
	gutil = require('gulp-util');

gulp.task('coffee', function () {
	gulp.src('app/src/*.coffee')
		.pipe(coffee({bare: true}).on('error', gutil.log))
		.pipe(gulp.dest('app/dist'));
});

gulp.task('lint', function () {
	gulp.src('app/src/*.coffee')
		.pipe(coffeelint())
		.pipe(coffeelint.reporter());	
});

gulp.task('watch', function () {
	gulp.watch('./app/src/*.coffee', ['coffee', 'lint']);
});

gulp.task('default', ['coffee', 'lint', 'watch'])