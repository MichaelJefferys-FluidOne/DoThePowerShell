# generate a random string and return it
$randomString = [System.IO.Path]::GetRandomFileName() -replace '\.',''
$randomString
