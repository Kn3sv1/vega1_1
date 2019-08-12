C:\Users\r_satanovskyi\projects\vega1_1>webpack -v
4.17.2

C:\Users\r_satanovskyi\projects\vega1_1>npx webpack -v
3.12.0

C:\Users\r_satanovskyi\projects\vega1_1>npx webpack --config webpack.config.vendor.js


https://stackoverflow.com/questions/37906647/webpack-angular2-compiling-error

For me it was caused by the angular2-universal-polyfills package that contains an old version of the reflect-metadata package. I've fixed it by downloading the actual reflect-metadata with npm:

>>>npm install reflect-metadata


Then copied the node_modules\reflect-metadata folder into the node_modules\angular2-universal-polyfills\node_modules folder, rewriting the old one there.

Hope this helps someone facing this issue. I was working on an old project with angular2.4.5 and webpack.


The template has not been updated for webpack 4, 
you should try with webpack 3. (you can install it locally and use npx webpack --version to run the local webpack)
https://www.bountysource.com/issues/55571135-typeerror-dep-getresourceidentifier-is-not-a-function


https://www.udemy.com/aspnet-core-angular/learn/lecture/6986234#overview




C:\Users\r_satanovskyi\projects\vega1_1>npx webpack




npm install
$ dotnet restore
$ webpack --config webpack.config.vendor.js
$ webpack 
$ dotnet watch run 