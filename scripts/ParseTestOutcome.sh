#!/bin/bash
xmllint --xpath "string(//*[local-name()='UnitTestResult'][@testName='$1']/@outcome)" $(dirname "$0")/../tests/Test/TestResults/testoutput.xml