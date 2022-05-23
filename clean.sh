echo 'kill dotnet'
killall dotnet;
echo '-----------'
echo 'remove old dlls'
rm -rf obj/;
rm -rf bin/;
echo '-----------'
echo '-----------'
echo 'done'